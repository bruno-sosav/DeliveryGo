# DeliveryGo
Integrantes Enzo Casanovas, Alen Lantaño y Bruno Sosa Villamon
**¿QUE HACE EL PROGRAMA?**
Nuestro objetivo fue desarrollar un checkout moderno y eficiente para un cliente dedicado al servicio de delivery, priorizando una experiencia rápida, liviana e intuitiva. Diseñamos una solución pensada para agilizar el proceso de compra, mejorar la usabilidad y ofrecer a nuestro cliente una herramienta funcional, práctica y visualmente atractiva, adaptada a las necesidades del rubro.
**¿QUE TECNOLOGIAS USAMOS?**
Desarrollamos el proyecto utilizando el lenguaje C#, aprovechando su potencia y versatilidad para construir una aplicación robusta y eficiente. Optamos por una implementación en consola, priorizando la simplicidad, el rendimiento y la facilidad de uso, manteniendo un enfoque claro en la funcionalidad y la experiencia del usuario.
**¿QUE NECESIDAD SATISFACE?**
Con este desarrollo logramos optimizar el orden y la velocidad en el proceso de gestión de pedidos, brindando una solución eficiente para los servicios de delivery. De esta manera, facilitamos la organización de los pedidos y mejoramos significativamente los tiempos de respuesta, elevando la calidad y productividad del servicio.
**¿EN QUE RUBROS/ACTIVIDADES PODRIA SER APLICADO?**
Este sistema puede adaptarse a diversos sectores que requieran gestionar pedidos o entregas de manera ágil y organizada. Además del rubro de delivery gastronómico, su estructura flexible permite implementarlo en:

**Comercios minoristas que ofrezcan reparto a domicilio.**

**Farmacias con servicio de entrega rápida.**

**Tiendas de tecnología o indumentaria con gestión de pedidos online.**

**Supermercados que busquen optimizar sus procesos de envío.**

**Empresas logísticas o de mensajería, que necesiten un control eficiente de órdenes.**

En resumen, es una herramienta versátil que puede aplicarse en cualquier negocio que busque mejorar la organización y la velocidad en la gestión de pedidos.

**COMO SE UTILIZA LA APLICACION**
Paso 1:Descargar el repositorio.
Paso 2:Abrir el proyecto en visual studio/Rider/VS Code con NET SDK.
Paso 3:Compilar el proyecto.
Paso 4:Ejecutar en consola (o ejecutar el debug):dotnet run.
Paso 5:Seguir las opciones del menu(agregar items,elegir envio,pagar,confirmar pedido).

**Patrones que se utilizaron**
*Patrones de Diseño en DeliveryGo*
Resumen de Patrones Aplicados
🛒 Command + Undo/Redo - Carrito
Uso: Operaciones del carrito (agregar, quitar, cambiar cantidad)

Beneficio: Permite deshacer/rehacer cambios con historial completo

🚚 Strategy - Métodos de Envío
Uso: Cálculo de costos de envío (Moto, Correo, Retiro)

Beneficio: Cambiar método de envío en tiempo real sin modificar código

⚙ Singleton - Configuración Global
Uso: Parámetros globales (IVA, umbral envío gratis)

Beneficio: Configuración centralizada y accesible desde toda la app

💳 Factory + Adapter - Sistema de Pagos
Factory: Creación de métodos de pago (Tarjeta, Transferencia, MP)

Adapter: Integración SDK externa de Mercado Pago

Beneficio: Sistema extensible para nuevos métodos de pago

🎁 Decorator - Modificadores de Pago
Uso: Aplicar IVA y cupones a pagos

Beneficio: Agregar funcionalidades dinámicamente sin modificar código base

📦 Builder - Construcción de Pedidos
Uso: Crear pedidos complejos paso a paso

Beneficio: Validación integrada y código más legible

🔔 Observer - Notificaciones
Uso: Notificar cambios de estado a Cliente, Logística y Auditoría

Beneficio: Comunicación en tiempo real desacoplada

🚪 Facade - Interfaz Unificada
Uso: Orquestar todos los patrones en una API simple

Beneficio: Ocultar complejidad del sistema detrás de interfaz sencilla

**Caso narrado del uso**
Carlos abre la aplicación DeliveryGo y ve el menú principal:
┌─────────────────────────────┐
│   === DELIVERYGO - MENÚ ===  │
│   1. Agregar ítem al carrito │
│   2. Cambiar cantidad        │
│   3. Quitar ítem            │
│   4. Ver resumen de compra   │
│   5. Deshacer                │
│   6. Rehacer                 │
│   7. Elegir método de envío  │
│   8. Realizar pago          │
│   9. Confirmar pedido       │
│   10. Desuscribir Logística │
│   0. Salir                  │
└─────────────────────────────┘

