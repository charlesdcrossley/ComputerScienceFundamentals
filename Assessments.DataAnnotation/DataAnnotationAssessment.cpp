#include <iostream>
#include <string>
#include <curl/curl.h>
#include "libxml/HTMLparser.h"
#include "libxml/xpath.h"
#include <map>
using namespace std;

// References 
// https://www.zenrows.com/blog/c-plus-plus-web-scraping
// https://www.pudn.club/programming/network-programming-in-c-plus-plus-understanding-the-libcurl-library/

size_t WriteCallback(char *contents, size_t size, size_t nmemb, std::string *data) {
    std::string* buffer = data;
    buffer->append(contents, size * nmemb);
    return size * nmemb;
}

int main() {
    CURL* curl;
    CURLcode res;
    string response;
    map<map<int, int>, xmlChar*> characterCoordinates; 

    curl_global_init(CURL_GLOBAL_DEFAULT);
    curl = curl_easy_init();

    if (curl) {
        curl_easy_setopt(curl, CURLOPT_URL, "https://docs.google.com/document/d/e/2PACX-1vTMOmshQe8YvaRXi6gEPKKlsC6UpFJSMAk4mQjLm_u1gmHdVVTaeh7nBNFBRlui0sTZ-snGwZM4DBCT/pub");
        curl_easy_setopt(curl, CURLOPT_WRITEFUNCTION, WriteCallback);
        curl_easy_setopt(curl, CURLOPT_WRITEDATA, &response);

        res = curl_easy_perform(curl);
        if (res == CURLE_OK) {
            cout << response << std::endl;
        }

        curl_easy_cleanup(curl);
    }
    htmlDocPtr doc = htmlReadMemory(response.c_str(), response.length(), "UTF-8","UTF-8", HTML_PARSE_NOERROR);
    xmlXPathContextPtr context = xmlXPathNewContext(doc);
    
    // Using XPath, grabs the table from the div container "doc-content"
    xmlXPathObjectPtr characterCoordinatesTable =  xmlXPathEvalExpression((xmlChar*) "//div[contains(@class,'doc-content')]//table//tr", context);

    // 
    int maxX = 0; 
    int maxY = 0; 

    for(int i=1; i < characterCoordinatesTable->nodesetval->nodeNr; i++) 
    {
        // 
        xmlNodePtr coordinateRow = characterCoordinatesTable->nodesetval->nodeTab[i];
        
        // Set context to current coordinate row 
        xmlXPathSetContextNode(coordinateRow, context);

        xmlNodePtr xCoordinate = xmlXPathEvalExpression((xmlChar *) "//td[1]", context)->nodesetval->nodeTab[i];
        xmlNodePtr yCoordinate = xmlXPathEvalExpression((xmlChar *) "//td[3]", context)->nodesetval->nodeTab[i];
        xmlNodePtr unicodeCharacter = xmlXPathEvalExpression((xmlChar *) "//td[2]", context)->nodesetval->nodeTab[i];

        xmlChar *content = xmlNodeGetContent(coordinateRow);
        
        xmlChar *xCoordinateContent = xmlNodeGetContent(xCoordinate);
        int xCoordinateValue = strtol((const char*)xCoordinateContent, nullptr, 10); 
        
        xmlChar *yCoordinateContent = xmlNodeGetContent(yCoordinate);
        int yCoordinateValue = strtol((const char*)yCoordinateContent, nullptr, 10); 

        maxX = max(maxX, xCoordinateValue);
        maxY = max(maxY, yCoordinateValue);

        characterCoordinates[{{xCoordinateValue, yCoordinateValue}}] = xmlNodeGetContent(unicodeCharacter);
    }

    // (0,2), (1, 2), (2, 2), (3, 2)
    // (0,1), (1, 1), (2, 1)
    // (0,0) 
    for(int i = maxY; i >= 0; i--)
    {   
        for(int j = 0; j <= maxX; j++)
        {
            if(characterCoordinates.find({{j, i}}) == characterCoordinates.end()) {
                cout << "";
            }
            else {
                cout << characterCoordinates[{{j, i}}];
            }
        }
        cout << endl;
    }   
    curl_global_cleanup();
    return 0;
}
