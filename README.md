# SowardSolutions
This is a build of the demo MVC application from Adam Freeman's ASP.Net Core 3 text book. This is for demonstration purpose. 

## Build Script

        dotnet new globaljson --sdk-version 5.0.103 --output SowardSolutions/ConsultingProducts
        dotnet new web --no-https --output SowardSolutions/ConsultingProducts --framework net5.0
        dotnet new sln -o SowardSolutions
        dotnet sln SowardSolutions add SowardSolutions/ConsultingProducts 
        dotnet new xunit -o SowardSolutions/ConsultingProducts.Tests --framework net5.0
        dotnet sln SowardSolutions add SowardSolutions/ConsultingProducts.Tests 
        dotnet add SowardSolutions/ConsultingProducts.Tests reference SowardSolutions/ConsultingProducts 
