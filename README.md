CrossDemo
=========

Código de demo de mi sesión "Desarrollo de apps móviles multiplataforma con C# y Xamarin"

Puedes encontrar más detalles sobre este código en este post:

Desarrollo de apps multiplataforma con C# y Xamarin
http://blogs.msdn.com/b/esmsdn/archive/2014/03/10/desarrollo-de-apps-multiplataforma-con-c-y-xamarin.aspx

En la carpeta "CrossDemo 1 Inicial" se puede ver un pequeño proyecto de Windows Phone que muestra unos datos en pantalla y los manipula. Toda la lógica del ejemplo está en el Code Behing de la página. Este proyecto ha sido creado con Visual Studio 2013.

En la carpeta "CrossDemo 2 MVVM" se puede ver el mismo ejemplo de antes pero implementando MVVM. Este proyecto también ha sido creado con Visual Studio 2013.
Nota: en este ejemplo no he añadido ViewModelLocator o NavigationService por simplicidad. Aquí puedes ver un ejemplo de MVVM que los incluye: http://alejandrocamposmagencio.com/2013/04/22/windows-phone-tips-tricks-ejemplo-de-implementacion-del-patron-mvvm/

En la carpeta "CrossDemo 3 Final" se puede ver el mismo ejemplo de antes, pero ahora el View Model y el Model están en una Portable Class Library (PCL) que se comparte entre el proyecto de Windows Phone, uno de Windows 8.1 y uno de Android. Este proyecto ha sido creado con Visual Studio 2013 Ultimate (con Pro o superior es suficiente para poder usar PCLs) y Xamarin (para poder desarrollar para Android con C#).

Un saludo,

Alejandro Campos Magencio
Microsoft Technical Evangelist
