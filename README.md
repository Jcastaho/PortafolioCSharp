¡Bienvenido a mi portafolio personal! Este proyecto es una aplicación web full-stack desarrollada con ASP.NET Core MVC, diseñada para mostrar mis habilidades, experiencia y proyectos en el mundo del desarrollo de software. La aplicación está completamente contenerizada con Docker y desplegada en la nube.

**[Ver Demo en Vivo 🚀](https://portafoliocsharp.onrender.com/)**

---

## 🛠️ Tecnologías Utilizadas

Este proyecto fue construido utilizando un stack de tecnologías moderno y robusto:

#### **Back-End**
* **C# y .NET 9:** Utilizando el framework más reciente para un rendimiento y seguridad óptimos.
* **ASP.NET Core MVC:** Para la estructura de la aplicación, siguiendo el patrón Modelo-Vista-Controlador.


#### **Front-End**
* **HTML5 y CSS3:** Para la estructura y el estilo de la web.
* **Bootstrap:** Para un diseño responsivo y componentes de UI modernos.


#### **Despliegue (DevOps)**
* **Docker:** La aplicación está completamente contenerizada, asegurando consistencia entre el entorno de desarrollo y producción.
* **Render.com:** Plataforma en la nube para el alojamiento y despliegue continuo del contenedor Docker.

---

## 🚀 Despliegue

Este proyecto está configurado para **Despliegue Continuo (CI/CD)** en [Render.com](https://render.com/). El flujo de trabajo es el siguiente:

1.  Se realiza un `git push` a la rama `master` del repositorio en GitHub.
2.  Un webhook notifica a Render sobre los nuevos cambios.
3.  Render clona la última versión del código.
4.  Se construye una nueva imagen de Docker a partir del `Dockerfile`.
5.  La nueva imagen se despliega automáticamente, actualizando la aplicación en vivo sin tiempo de inactividad.

