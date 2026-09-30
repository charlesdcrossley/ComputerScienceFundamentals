### MS Build Tools MSVS (cl.exe)
```cmd
cmd.exe /c ""C:\Program Files (x86)\Microsoft Visual Studio\18\BuildTools\Common7\Tools\VsDevCmd.bat" -arch=amd64 && cl.exe" /Zi /EHsc   /nologo /IC:\vcpkg\packages\curl_x64-windows\include -IC:\Repositories\ComputerScienceFundamentals\vcpkg\packages\libxml2_x64-windows\include\libxml2 DataAnnotationAssessment.cpp  /link /LIBPATH:C:\vcpkg\packages\curl_x64-windows\lib /LIBPATH:C:\Repositories\ComputerScienceFundamentals\vcpkg\packages\libxml2_x64-windows\lib  libcurl.lib libxml2.lib
```

### msys64 Compile (g++)
```cmd 
g++ -IC:\vcpkg\packages\curl_x64-windows\include -IC:\Repositories\ComputerScienceFundamentals\vcpkg\packages\libxml2_x64-windows\include\libxml2  DataAnnotationAssessment.cpp -o DataAnnotationAssessment -LC:\vcpkg\packages\curl_x64-windows\lib -LC:\Repositories\ComputerScienceFundamentals\vcpkg\packages\libxml2_x64-windows\lib -lcurl -llibxml2
```