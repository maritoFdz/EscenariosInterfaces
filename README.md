# Laboratorio — Escenarios e Interfaces en C#

📅 Fecha: 08/09/2026

## 📋 Contenido del Repositorio

Este repositorio contiene tres ejercicios desarrollados en C# utilizando Windows Forms, en los cuales se aplican diferentes conceptos de programación orientada a objetos, interfaces, herencia, polimorfismo, validación de datos, manejo de archivos de configuración y diseño de interfaces gráficas.

El **Escenario 1** implementa un sistema para registrar trabajadores de dos tipos: trabajadores con salario fijo y trabajadores por comisión. Se utiliza una interfaz `ITrabajador` para establecer los elementos comunes entre ambos tipos de trabajadores y se aplica polimorfismo para calcular el salario final.

El **Escenario 2** desarrolla una aplicación para calcular el área y perímetro de diferentes figuras geométricas. Se utiliza la interfaz `IFigura`, una clase abstracta `Triangulo` y diferentes clases derivadas para representar los tipos de triángulos. La aplicación permite seleccionar dinámicamente la figura y solicita únicamente los datos necesarios para realizar los cálculos.

El **Escenario 3** implementa un sistema básico de registro de usuarios. La aplicación obtiene parámetros desde un archivo externo `config.xml`, valida el nombre de usuario, el correo electrónico y la longitud de la contraseña, y muestra mensajes de validación mediante `ErrorProvider`.

## 🛠 Tecnologías Utilizadas

* **Lenguaje:** C#
* **Framework:** .NET / Windows Forms
* **Escenario 1 y 2:** Windows Forms
* **Escenario 3:** Windows Forms con .NET 9
* **IDE recomendado:** Visual Studio
* **Control de versiones:** Git / GitHub
* **Conceptos aplicados:** Interfaces, herencia, polimorfismo, clases abstractas, propiedades, eventos, validación de datos, `DataGridView`, `ErrorProvider`, expresiones regulares y archivos XML.

## 💻 Capturas de Pantalla y Problemas

### Interfaz Principal

* **Escenario 1 – Sistema de trabajadores:** Se desarrolla una aplicación Windows Forms para registrar trabajadores según su modalidad de pago. La aplicación permite seleccionar entre un trabajador con salario fijo y un trabajador por comisión.

  Para establecer una estructura común se crea la interfaz `ITrabajador`, que define las propiedades `Nombre` y `SalarioBase`, además del método `CalcularSalarioFinal()`. Tanto `TrabajadorFijo` como `TrabajadorXComision` implementan esta interfaz.

  La clase `TrabajadorFijo` calcula su salario final devolviendo directamente el salario base. En cambio, `TrabajadorXComision` posee una propiedad adicional llamada `Comision` y calcula el salario final sumando el salario base y la comisión.

  En el formulario principal se mantiene una lista de trabajadores mediante `List<ITrabajador>`. Esto permite almacenar objetos de diferentes clases que implementan la misma interfaz. Dependiendo del botón de opción seleccionado, se crea un objeto `TrabajadorFijo` o `TrabajadorXComision`.

  Antes de registrar un trabajador se validan los datos introducidos. El nombre no puede estar vacío y el salario base debe ser numérico y mayor que cero. Si se selecciona el trabajador por comisión, también se valida que la comisión sea numérica y mayor que cero. Los errores se muestran mediante `ErrorProvider`.

  También se controla la entrada del campo nombre mediante el evento `KeyPress`, evitando que se introduzcan números. Una vez registrado el trabajador, el método `ActualziarGrid()` crea un `DataTable` con las columnas de nombre, salario base, comisión, salario final y tipo de trabajador, y posteriormente lo muestra en un `DataGridView`.

  Este escenario permite demostrar principalmente el uso de **interfaces, polimorfismo, encapsulamiento, listas genéricas, validación de formularios y controles de Windows Forms**.

  <img width="650" height="389" alt="image" src="https://github.com/user-attachments/assets/da2e64a8-76c4-412e-a965-db65e9a60773" />


* **Escenario 2 – Cálculo de figuras geométricas:** Se desarrolla una aplicación gráfica para calcular el área y perímetro de diferentes figuras geométricas: círculo, rectángulo y triángulos equilátero, isósceles y escaleno.

  Para establecer las operaciones comunes se crea la interfaz `IFigura`, que define los métodos `CalcularArea()` y `CalcularPerimetro()`. De esta forma, todas las figuras deben proporcionar una implementación para calcular ambas propiedades geométricas.

  La clase `Circulo` implementa `IFigura` y utiliza la propiedad `Radio`. El área se calcula mediante `Math.PI * Radio * Radio`, mientras que el perímetro se calcula mediante `2 * Math.PI * Radio`.

  La clase `Rectangulo` también implementa `IFigura` y posee las propiedades `Base` y `Altura`. Su área se obtiene multiplicando ambas dimensiones y su perímetro mediante `2 * (Base + Altura)`.

  Para los triángulos se utiliza una clase abstracta llamada `Triangulo`. Esta clase contiene las propiedades `Base` y `Altura`, implementa el cálculo común del área y deja el cálculo del perímetro como un método abstracto que debe ser implementado por las clases derivadas.

  A partir de `Triangulo` se crean tres clases especializadas. `TrianguloEquilatero` calcula el perímetro multiplicando la base por tres; `TrianguloIsosceles` utiliza la base y dos lados iguales; y `TrianguloEscaleno` suma la base y los lados B y C.

  El formulario permite seleccionar mediante botones de opción el tipo de figura. Dependiendo de la selección, los controles de entrada se habilitan, deshabilitan o muestran dinámicamente. Por ejemplo, al seleccionar un círculo solamente se solicita el radio, mientras que al seleccionar un triángulo también se muestran las opciones para escoger entre equilátero, isósceles o escaleno.

  Al presionar el botón de cálculo, se crea una referencia `IFigura` y se instancia la clase correspondiente según la selección del usuario. Después se llaman `CalcularArea()` y `CalcularPerimetro()` sobre esa referencia, mostrando los resultados en el formulario. Esto demuestra el uso del **polimorfismo**, ya que la misma referencia `IFigura` puede representar diferentes tipos de figuras.

  También se implementa validación de los valores numéricos para evitar números vacíos, negativos o iguales a cero. El evento `KeyPress` limita los caracteres permitidos en los campos numéricos y `ErrorProvider` muestra los errores encontrados.

  Este escenario permite aplicar principalmente **interfaces, clases abstractas, herencia, polimorfismo, métodos abstractos, propiedades y validación de datos en Windows Forms**.

  <img width="492" height="402" alt="image" src="https://github.com/user-attachments/assets/1aa9cb99-84bd-43e9-8bdc-eaf7be2c9e21" />


* **Escenario 3 – Sistema de registro de usuarios y configuración externa:** Se desarrolla una aplicación Windows Forms para registrar usuarios mediante un formulario que solicita un nombre de usuario, correo electrónico y contraseña.

  Una de las características principales de este escenario es que ciertos parámetros de la aplicación no están escritos directamente en el formulario, sino que se almacenan en un archivo externo llamado `config.xml`. El archivo contiene el título de la aplicación, la longitud mínima de la contraseña y el número máximo de intentos fallidos.

  La clase estática `ConfigApp` se encarga de cargar esta configuración. El método `Cargar()` obtiene la ubicación del archivo utilizando `Application.StartupPath`, carga el documento XML mediante `XDocument.Load()` y recorre los elementos `Parametro` para obtener cada valor.

  Los parámetros obtenidos son almacenados en las propiedades `TituloApp`, `LongitudMinimaPassword` y `MaxIntentosFallidos`. En caso de que el archivo no pueda ser leído, la aplicación utiliza valores predeterminados y muestra un mensaje indicando que no se pudo cargar el archivo de configuración.

  La clase `Utilidades` contiene métodos estáticos para realizar las validaciones. `ValidarCorreo()` comprueba que el correo no esté vacío y utiliza una expresión regular para verificar que tenga una estructura básica de correo electrónico. `PasswordCorrecta()` comprueba que la contraseña no esté vacía y que su longitud sea igual o superior al mínimo establecido en la configuración.

  Cuando se carga el formulario, se ejecuta `ConfigApp.Cargar()`. Posteriormente, el título de la ventana se establece utilizando `ConfigApp.TituloApp` y se muestra al usuario la longitud mínima requerida para la contraseña.

  Al presionar el botón de registro, se validan individualmente el usuario, el correo y la contraseña. Los errores se muestran mediante `ErrorProvider`. Si alguno de los datos no cumple los requisitos, se muestra un mensaje indicando al usuario que debe corregir los campos marcados. Si todos los datos son válidos, se muestra el mensaje "Usuario registrado!".

  El proyecto utiliza Windows Forms y está configurado para ejecutarse con `net9.0-windows`. Además, el archivo `config.xml` está configurado para copiarse automáticamente al directorio de salida cuando se compila el proyecto.

  Este escenario permite aplicar conceptos de **archivos XML, configuración externa, clases estáticas, expresiones regulares, validación de formularios, propiedades y eventos de Windows Forms**.

  <img width="644" height="269" alt="image" src="https://github.com/user-attachments/assets/cc5fd66f-9285-4a52-85e4-885acb66b9d4" />


## 📁 Estructura de Carpetas o Directorios

```text
EscenariosInterfaces/
├── Escenario1/
│   ├── Form1.cs                  # Formulario principal
│   ├── Form1.Designer.cs         # Diseño del formulario
│   ├── ITrabajador.cs            # Interfaz para los trabajadores
│   ├── TrabajadorFijo.cs         # Trabajador con salario fijo
│   ├── TrabajadorXComision.cs    # Trabajador con salario + comisión
│   ├── Program.cs                # Punto de entrada
│   └── Escenario1.csproj         # Configuración del proyecto
│
├── Escenario2/
│   ├── Form1.cs                  # Formulario principal
│   ├── Form1.Designer.cs         # Diseño del formulario
│   ├── IFigura.cs                # Interfaz para las figuras
│   ├── Circulo.cs                # Clase círculo
│   ├── Rectangulo.cs             # Clase rectángulo
│   ├── Triangulo.cs              # Clase abstracta Triangulo
│   ├── TrianguloEquilatero.cs    # Triángulo equilátero
│   ├── TrianguloIsosceles.cs     # Triángulo isósceles
│   ├── TrianguloEscaleno.cs      # Triángulo escaleno
│   ├── Program.cs                # Punto de entrada
│   └── Escenario2.csproj         # Configuración del proyecto
│
├── Escenario3/
│   ├── Form1.cs                  # Formulario de registro
│   ├── Form1.Designer.cs         # Diseño del formulario
│   ├── ConfigApp.cs              # Carga de configuración XML
│   ├── Utilidades.cs             # Métodos de validación
│   ├── config.xml                # Parámetros de configuración
│   ├── Program.cs                # Punto de entrada
│   └── Escenario3.csproj         # Configuración del proyecto
│
└── README.md                     # Documentación del proyecto
```

## ▶️ Instrucciones de Ejecución / Uso

1. Clonar el repositorio:

```bash
git clone https://github.com/maritoFdz/EscenariosInterfaces.git
cd EscenariosInterfaces
```

2. Abrir la solución correspondiente en **Visual Studio**.

3. Para ejecutar **Escenario1**, abrir el proyecto `Escenario1` y establecerlo como proyecto de inicio. Ejecutar la aplicación y seleccionar el tipo de trabajador que se desea registrar.

4. Introducir el nombre y el salario base. Si se selecciona la opción de trabajador por comisión, ingresar también el valor de la comisión.

5. Presionar el botón de agregar. Si los datos son válidos, el trabajador será agregado al listado y aparecerá en el `DataGridView` junto con su salario final y tipo.

6. Para ejecutar **Escenario2**, establecer `Escenario2` como proyecto de inicio. Seleccionar una figura geométrica y completar los valores solicitados.

7. Presionar el botón de cálculo para obtener el área y perímetro de la figura seleccionada.

8. Para los triángulos, seleccionar además si se trata de un triángulo equilátero, isósceles o escaleno e introducir los lados adicionales cuando sean necesarios.

9. Para ejecutar **Escenario3**, establecer `Escenario3` como proyecto de inicio. Verificar que el archivo `config.xml` se encuentre incluido en el proyecto y sea copiado al directorio de salida.

10. Introducir un nombre de usuario, un correo electrónico válido y una contraseña que cumpla con la longitud mínima establecida en `config.xml`.

11. Presionar el botón de registro. Si todos los datos son correctos, se mostrará el mensaje de confirmación correspondiente.

## 👤 Autor y Contexto

* **Nombre:** Mario Fernández Morales, Kevin Esquivel, Norlan Ortega
* **Institución:** Universidad Tecnológica de Panamá (UTP)
* **Fecha de Realización:** 20/09/2026

## 📚 Referencias

* Documentación oficial de C# — Interfaces, herencia y polimorfismo (Microsoft Learn)
* Documentación oficial de .NET — Windows Forms
* Documentación oficial de .NET — `DataTable`, `List<T>` y `ErrorProvider`
* Documentación oficial de .NET — Expresiones regulares (`Regex`)
* Documentación oficial de .NET — Procesamiento de archivos XML mediante `XDocument`
* Repositorio del proyecto — [EscenariosInterfaces](https://github.com/maritoFdz/EscenariosInterfaces)
