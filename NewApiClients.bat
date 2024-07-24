pushd %~dp0

Kama.ApiManagement\KamaTools\KamaTools.exe -apiClientsForNetCore "_apiAssembly:Kama.ApiManagement\bin\net7.0\Kama.ApiManagement.dll" "_modelAssembly:Kama.ApiManagement\bin\net7.0\Kama.ApiManagement.Core.Model.dll" "_modelFilePath:ApiClient\.NetCore\Kama.ApiManagement.Core.Model.cs" "_apiClientFilePath:ApiClient\.NetCore\Kama.ApiManagement.ApiClient.cs" "_controllerBaseTypeName:BaseApiController" "_serviceName:ApiManagement" "_serviceNamespace:Kama.ApiManagement.ApiClient" "_modelNameSpace:Kama.ApiManagement.Core.Model"

Kama.ApiManagement\KamaTools\KamaTools.exe -apiClientsForNetFramework "_apiAssembly:Kama.ApiManagement\bin\net7.0\Kama.ApiManagement.dll" "_modelAssembly:Kama.ApiManagement\bin\net7.0\Kama.ApiManagement.Core.Model.dll" "_modelFilePath:ApiClient\.NetFrameWork\Kama.ApiManagement.Core.Model.cs" "_apiClientFilePath:ApiClient\.NetFrameWork\Kama.ApiManagement.ApiClient.cs" "_controllerBaseTypeName:BaseApiController" "_serviceName:ApiManagement" "_serviceNamespace:Kama.ApiManagement.ApiClient" "_modelNameSpace:Kama.ApiManagement.Core.Model"


pause