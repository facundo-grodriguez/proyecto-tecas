# Proyecto de Gestión de Alumnos

Este proyecto permite gestionar información sobre alumnos, incluyendo sus datos personales y notas. A continuación se describen las funcionalidades principales.

## Funcionalidades

### 1. Alta de Alumno
- **Descripción**: Permite agregar un nuevo alumno al sistema.
- **Datos requeridos**:
  - **DNI**: Identificador único del alumno.
  - **Nombre**: Nombre completo del alumno.
  - **Nota1**: Primera nota del alumno.
  - **Nota2**: Segunda nota del alumno.

### 2. Baja de Alumno
- **Descripción**: Permite eliminar un alumno del sistema usando su DNI.
- **Proceso**: Se solicita el DNI del alumno a eliminar, y si existe en el sistema, se procederá a su eliminación.

### 3. Modificación de Alumno
- **Descripción**: Permite modificar los datos de un alumno existente.
- **Datos editables**: Se puede cambiar el nombre y las notas. Se identifica al alumno mediante su DNI.

### 4. Consulta de Alumno
- **Descripción**: Permite buscar y mostrar la información de un alumno específico.
- **Método**: Se puede consultar usando el DNI, y se mostrará el nombre y las notas correspondientes.

### 5. Nota Más Alta
- **Descripción**: Permite obtener la nota más alta de todos los alumnos.
- **Proceso**: Se revisan todas las notas y se presenta la más alta entre Nota1 y Nota2.

### 6. Promedio General
- **Descripción**: Calcula el promedio de las notas de cada alumno.
- **Método**: Se suman todas las notas y se divide por el número total de notas.

## Estructura de Datos

Cada alumno tiene los siguientes atributos:
- **DNI**: `String`
- **Nombre**: `String`
- **Nota1**: `Float`
- **Nota2**: `Float`

## Uso

1. **Instalación**: 
   - Clona el repositorio:
     ```bash
     git clone https://github.com/facundo-grodriguez/proyecto-gestion-alumnos.git
     ```
   - Navega al directorio del proyecto:
     ```bash
     cd proyecto-gestion-alumnos
     ```
   - Compila y ejecuta el proyecto según las instrucciones específicas de tu entorno.

2. **Ejemplos de uso**: Usa los siguientes comandos para interactuar con el sistema:

   - **Agregar un alumno**:
     ```bash
     agregar_alumno --dni 12345678 --nombre "Juan Pérez" --nota1 8.5 --nota2 9.0
     ```

   - **Eliminar un alumno**:
     ```bash
     eliminar_alumno --dni 12345678
     ```

   - **Modificar un alumno**:
     ```bash
     modificar_alumno --dni 12345678 --nombre "Juan Pérez Gómez" --nota1 9.5
     ```

   - **Consultar un alumno**:
     ```bash
     consultar_alumno --dni 12345678
     ```

   - **Obtener la nota más alta**:
     ```bash
     nota_mas_alta
     ```

   - **Calcular el promedio general**:
     ```bash
     promedio_general
     ```

3. **Contribuciones**: Si deseas contribuir, abre un pull request con tus cambios y asegúrate de seguir las pautas de estilo del código.

3. **Contribuciones**: Instrucciones sobre cómo contribuir al proyecto.