# 🛍️ Tienda_01 - Aplicación Web de Tienda Virtual

**Tienda_01** es una aplicación web desarrollada con **ASP.NET Framework** y **SQL Server** como base de datos. El proyecto implementa una arquitectura en capas utilizando el patrón de diseño **MVC (Modelo-Vista-Controlador)** y está orientado a la gestión completa de una tienda en línea, incluyendo panel de administración, catálogo de productos, registro de clientes, procesamiento de ventas, y pagos integrados con PayPal.

---

## 📐 Arquitectura del Proyecto

La solución se encuentra dividida en cinco capas, cada una con responsabilidades específicas:

- **CapaEntidad**: Contiene las clases que definen las entidades del negocio (Producto, Cliente, Venta, etc.).
- **CapaDatos**: Responsable del acceso a la base de datos mediante procedimientos almacenados.
- **CapaNegocio**: Gestiona la lógica de negocio y actúa como puente entre los datos y la presentación.
- **CapaPresentacionAdministrador**: Interfaz para el administrador donde puede gestionar productos, clientes, categorías, etc.
- **CapaPresentacionTienda**: Interfaz pública para los usuarios/clientes donde pueden navegar el catálogo, registrarse y realizar compras.

---

## 🧰 Tecnologías utilizadas

🧱 ASP.NET Framework

🗄️ SQL Server (base de datos relacional)

🧩 Arquitectura en capas (Entity, Data, Business, Presentation)

🖼️ MVC (Model-View-Controller)

💅 Bootstrap (para diseño responsivo)

⚙️ JavaScript (para la lógica de cliente y conexión backend)

💳 Integración con PayPal (pagos reales)

---

## 🚀 Funcionalidades Principales

🔐 Registro e inicio de sesión de clientes

🛒 Catálogo de productos y carrito de compras

💰 Proceso de pago con PayPal

📦 Gestión de productos, categorías y stock

🧑‍💼 Panel de administración (ventas, productos, clientes)

📈 Dashboard con métricas generales

---

## 🧱 Estructura del Proyecto ##
El sistema está organizado bajo una arquitectura en capas:

├── CapaEntidad
│ └── Entidades del dominio (Producto, Cliente, etc.)
├── CapaDatos
│ └── Acceso a datos con SQL Server
├── CapaNegocio
│ └── Lógica de negocio (servicios)
├── CapaPresentacionAdministrador
│ └── Interfaz de administración (gestión de productos, clientes, ventas)
├── CapaPresentacionTienda
│ └── Frontend de la tienda para los clientes


---


## 📸 Capturas de Pantalla

![image](https://github.com/user-attachments/assets/cdc6abea-ace9-4a7c-94a0-23dd61b53df9)
---
![image](https://github.com/user-attachments/assets/82caaadb-aee7-4275-b30c-e92a69d380d2)
---
![image](https://github.com/user-attachments/assets/c0e468d4-8bae-489f-a2f4-8cf24719f0db)
---
![image](https://github.com/user-attachments/assets/d0d2affb-d9ee-40bf-ba88-cf5714fe257a)
---
![image](https://github.com/user-attachments/assets/ab442c6e-d53d-4cf3-bf3b-c9995753d5a6)
---
![image](https://github.com/user-attachments/assets/5cf26369-bc84-4a2d-9b8c-88063ac094cd)
---
![image](https://github.com/user-attachments/assets/482cbe0b-333a-4e64-a7f2-b5f53f9c2e05)
---
![image](https://github.com/user-attachments/assets/708e2742-0cf1-40cb-8445-83389eb90b5b)

---

## 🗃️ Base de Datos

El sistema utiliza SQL Server con procedimientos almacenados para realizar las operaciones CRUD. La base de datos incluye tablas como:

- `PRODUCTO`
- `CATEGORIA`
- `CLIENTE`
- `VENTA`
- `DETALLE_VENTA`

---

## ⚙️ Instalación y Ejecución

### 🔧Requisitos
- Visual Studio 2019 o superior
- SQL Server (o SQL Server Express)
- .NET Framework
- Bootstrap y jQuery incluidos en el proyecto
- Cuenta de desarrollador PayPal (para pruebas)

### ▶️ Pasos para ejecutar el proyecto
1. Clonar el repositorio:
   git clone https://github.com/Fermoyano07/tienda-virtual.git
2. Abrir la solución .sln en Visual Studio.

3. Restaurar los paquetes NuGet necesarios.

4. Configurar la cadena de conexión a la base de datos en App.config o Web.config.

5. Ejecutar el script de la base de datos desde /BD/Script.sql (si está disponible).

6. Establecer como proyecto de inicio:
    • CapaPresentacionTienda para la tienda
    • CapaPresentacionAdministrador para el panel de administración

7. Ejecutar el proyecto.

## 💳 Pruebas con PayPal
La aplicación está integrada con PayPal utilizando la modalidad sandbox para pruebas. Podés configurar tus credenciales desde el panel de desarrollador de PayPal: https://developer.paypal.com/

## 👨‍💻 Autor
## Fernando Moyano
Técnico en Desarrollo de Software
## Visita mi Portfolio
🔗 https://fermoyano07.github.io/Portafolio-Fer/
