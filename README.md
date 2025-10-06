:

🚀 DeliveryGo

👥 Integrantes

Enzo Casanovas, Alen Lantaño y Bruno Sosa Villamon

🧩 ¿Qué hace el programa?

Nuestro objetivo fue desarrollar un checkout moderno y eficiente para un cliente dedicado al servicio de delivery, priorizando una experiencia rápida, liviana e intuitiva.
Diseñamos una solución enfocada en:

Agilizar el proceso de compra

Mejorar la usabilidad

Ofrecer una herramienta práctica y visualmente atractiva

🛠️ Tecnologías utilizadas

El proyecto fue desarrollado en C#, aprovechando su potencia y versatilidad para construir una aplicación robusta y eficiente.

🔹 Interfaz: Consola
🔹 Motivo: Simplicidad, rendimiento y facilidad de uso
🔹 Entorno compatible: Visual Studio, Rider, VS Code con .NET SDK

🎯 Necesidad que satisface

DeliveryGo mejora el orden y la velocidad en la gestión de pedidos, ofreciendo:

Organización más clara

Mejores tiempos de respuesta

Mayor productividad en servicios de delivery

🏪 Aplicación en distintos rubros

El sistema es adaptable a diversos sectores que requieran gestión ágil de pedidos:

🛍️ Comercios minoristas con reparto a domicilio

💊 Farmacias con entregas rápidas

👕 Tiendas de tecnología o indumentaria

🛒 Supermercados con servicios de envío

🚚 Empresas logísticas o de mensajería

Versátil y escalable: Aplicable en cualquier negocio que busque mejorar la organización y velocidad en la gestión de pedidos.

🧭 ¿Cómo se utiliza la aplicación?

📥 Descargar el repositorio

💻 Abrir el proyecto en Visual Studio / Rider / VS Code

⚙️ Compilar el proyecto

▶️ Ejecutar en consola con dotnet run

📋 Seguir las opciones del menú (agregar ítems, elegir envío, pagar, confirmar pedido)

🧠 Patrones de diseño utilizados
Patrón	Uso	Beneficio
Command + Undo/Redo	Operaciones del carrito	Deshacer/rehacer con historial
Strategy	Cálculo de costos de envío	Cambiar método sin modificar código
Singleton	Configuración global (IVA, envío gratis)	Acceso centralizado
Factory + Adapter	Sistema de pagos (tarjeta, transferencia, MP)	Extensibilidad e integración externa
Decorator	Aplicar IVA y cupones	Funcionalidades dinámicas sin modificar base
Builder	Construcción de pedidos	Validación integrada y claridad
Observer	Notificaciones en tiempo real	Comunicación desacoplada
Facade	Interfaz unificada de la app	Oculta la complejidad del sistema
🎬 Caso narrado de uso
👤 Usuario: Carlos

Carlos abre DeliveryGo y accede al menú principal:

┌─────────────────────────────┐
│   === DELIVERYGO - MENÚ ===  │
│ 1. Agregar ítem al carrito  │
│ 2. Cambiar cantidad         │
│ 3. Quitar ítem              │
│ 4. Ver resumen de compra    │
│ 5. Deshacer                 │
│ 6. Rehacer                  │
│ 7. Elegir método de envío   │
│ 8. Realizar pago            │
│ 9. Confirmar pedido         │
│ 10. Desuscribir Logística   │
│ 0. Salir                    │
└─────────────────────────────┘

🛒 Agrega ítems al carrito
SKU: MON001
Nombre: Monitor LED 24"
Precio: $45.000
Cantidad: 1
✓ Ítem agregado correctamente

SKU: TEC002
Nombre: Teclado Mecánico
Precio: $8.000
Cantidad: 1
✓ Ítem agregado correctamente

SKU: MOU003
Nombre: Mouse Inalámbrico
Precio: $5.000
Cantidad: 2  ← (Error, quería 1)
✓ Ítem agregado correctamente

↩️ Deshacer acción

Carlos presiona la opción 5 para deshacer el último ítem y corregir:

✓ Operación deshecha (Undo)

📋 Revisión del carrito
Monitor LED 24" (x1) - $45.000  
Teclado Mecánico (x1) - $8.000  
Mouse Inalámbrico (x1) - $5.000  ← ¡Ahora está correcto!

Subtotal: $58.000  
Costo de envío: $1.280  
TOTAL: $59.280

🔁 Rehacer acción

Carlos cambia de opinión y selecciona la opción 6:

✓ Operación rehecha (Redo)

🚚 Selección del método de envío
1. Moto ($1.280)  
2. Correo ($3.580 - Gratis desde $50.000)  
3. Retiro en tienda (Gratis)

→ Selecciona: 2
✓ Método de envío cambiado a: Correo

🧾 Ver resumen actualizado
Subtotal: $58.000  
Costo de envío: $0  ← ¡Envío gratis por superar $50.000!  
TOTAL: $58.000

💳 Realizar pago
Métodos disponibles:
1. Tarjeta
2. Transferencia
3. Mercado Pago
4. Mercado Pago (Adapter)

→ Selecciona: 1

¿Aplicar IVA? (s/n): s  
¿Aplicar cupón de descuento? (s/n): s  
% de descuento: 10%


Cálculo del pago:

- Aplicando cupón (10%): $58.000 → $52.200  
- Aplicando IVA (21%): $52.200 → $63.162  

✓ ¡Pago aprobado exitosamente!

✅ Confirmar pedido
Dirección: Av. Siempre Viva 742, Springfield  
Tipo de pago: Tarjeta

→ Confirmando pedido...

✓ Pedido #1 creado exitosamente:
  - Ítems: 3
  - Total: $58.000
  - Estado: Recibido

🚫 Desuscribirse de logística
✓ Logística desuscrita - no recibirá más notificaciones

📊 Diagrama UML
