Factura App - .NetFramework 4.8

📋 Descripción del Proyecto

Este es un ejemplo básico de una factura desarrollado en .NET Framework 4.8 utilizando Windows Forms, Entity Framework para acceso a datos, y Report Viewer para generación de reportes profesionales. La aplicación permite calcular impuestos (IVA) y generar facturas listas para imprimir.

🎯 Características Principales

✅ Proceso de Facturación
    Cálculo automático de subtotales e IVA
    Soporte para diferentes tasas impositivas (0%, 15%)
    Generación de números de factura consecutivos
    Cálculo de totales en tiempo real

✅ Reportes y Exportación
    Report Viewer integrado para visualización
    Formato profesional de facturas
    Capacidad de impresión directa
    Opción para guardar facturas

✅ Interfaz de Usuario
    Windows Forms intuitivo
    Validación de datos en tiempo real
    Diseño orientado a la productividad

🖼️ Capturas de Pantalla
Pantalla Principal de Facturación
<img width="1323" height="632" alt="imagen" src="https://github.com/user-attachments/assets/75c8f2d5-7e46-4398-a5cf-0302255bf950" />

Reporte de Factura
<img width="1027" height="650" alt="imagen" src="https://github.com/user-attachments/assets/dab17099-1c80-4eb2-bca9-b9cac5155e28" />

🏗️ Arquitectura del Proyecto
FACTURA_APP/
├── 📁 Formularios/
│   ├── frm_factura.cs          # Formulario principal de facturación
│   └── frm_reportes.cs         # Gestión de reportes
├── 📁 Models/
│   ├── DbContextVentas.cs      # Contexto de Entity Framework
│   ├── Factura.cs              # Modelo de factura
│   ├── Detalle_Factura.cs      # Modelo detalle de factura
│   ├── Producto.cs             # Modelo de producto
│   └── Parametro.cs            # Configuraciones del sistema
├── 📁 Reports/
│   └── rpt_factura.rdlc        # Plantilla de reporte RDLC
├── 📁 ds/
│   └── Ds_Ventas.xsd           # DataSet para Report Viewer
└── App.config                  # Configuración de conexión

⚙️ Tecnologías Utilizadas
Tecnología	Versión	Propósito
    .NET Framework	4.8	Plataforma principal
    C#	7.0+	Lenguaje de programación
    Entity Framework	6.x	ORM para acceso a datos
    SQL Server	2012+	Base de datos
    Report Viewer	15.x	Generación de reportes
    Windows Forms	-	Interfaz gráfica
    Git	-	Control de versiones

🚀 Requisitos Previos a la Instalación
    Visual Studio 2019/2022 con soporte para .NET Framework 4.8
    SQL Server 2012 o superior
    .NET Framework 4.8 Developer Pack
    Microsoft Report Viewer 2015+

¡Gracias por utilizar Factura App - .NetFramework 4.8 ! Si tienes alguna duda o problema, no dudes en abrir un issue en GitHub.

Este archivo README cubre desde la instalación hasta la ejecución, detalles sobre las tecnologías utilizadas, la configuración de la base de datos H2, y cómo acceder a la documentación de Swagger. ¡Espero que te sea útil para tu proyecto!
