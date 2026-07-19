# Actividad 2 – Flujo de Control Parte 2

## Descripción

Este programa fue desarrollado en C# utilizando estructuras repetitivas (bucles) y estructuras de decisión.

Permite registrar las cuatro calificaciones de una cantidad determinada de estudiantes, calcular el promedio de cada uno y determinar si el estudiante aprobó o reprobó.

## Objetivos

- Utilizar bucles para procesar múltiples estudiantes.
- Aplicar estructuras condicionales.
- Calcular promedios.
- Mostrar información en formato tabular.
- Fortalecer el uso de variables y operaciones aritméticas en C#.

## Funcionamiento

1. El usuario introduce la cantidad de estudiantes.
2. Para cada estudiante se solicita:
   - Nombre.
   - Nota 1.
   - Nota 2.
   - Nota 3.
   - Nota 4.
3. El sistema calcula el promedio.
4. Se determina el estatus:
   - Aprobado: promedio mayor o igual a 70.
   - Reprobado: promedio menor a 70.
5. Se muestran los resultados en forma de tabla.

---

# Casos de Prueba

## Caso 1 - Estudiante Aprobado

### Datos ingresados

- Nombre: Juan Pérez
- Nota 1: 80
- Nota 2: 75
- Nota 3: 90
- Nota 4: 85

### Resultado esperado

- Promedio: 82.50
- Estatus: Aprobado

### Evidencia

![Caso 1](capturas/caso1.png)

---

## Caso 2 - Estudiante Reprobado

### Datos ingresados

- Nombre: María Gómez
- Nota 1: 60
- Nota 2: 65
- Nota 3: 55
- Nota 4: 70

### Resultado esperado

- Promedio: 62.50
- Estatus: Reprobado

### Evidencia

![Caso 2](capturas/caso2.png)

---

## Caso 3 - Varios Estudiantes

### Datos ingresados

#### Estudiante 1

- Nombre: Carlos Rodríguez
- Nota 1: 75
- Nota 2: 80
- Nota 3: 70
- Nota 4: 90

#### Estudiante 2

- Nombre: Ana Martínez
- Nota 1: 60
- Nota 2: 65
- Nota 3: 70
- Nota 4: 68

### Resultado esperado

#### Carlos Rodríguez

- Promedio: 78.75
- Estatus: Aprobado

#### Ana Martínez

- Promedio: 65.75
- Estatus: Reprobado

### Evidencia

![Caso 3](capturas/caso3.png)

---

## Caso 4 - Promedio Exactamente en 70

### Datos ingresados

- Nombre: Pedro López
- Nota 1: 70
- Nota 2: 70
- Nota 3: 70
- Nota 4: 70

### Resultado esperado

- Promedio: 70.00
- Estatus: Aprobado

### Evidencia

![Caso 4](capturas/caso4.png)

---

# Conclusión

Mediante esta práctica se logró implementar estructuras repetitivas y condicionales en C# para procesar información de múltiples estudiantes. El programa calcula automáticamente los promedios y determina el estatus académico de cada estudiante de forma eficiente.

Además, se reforzaron conocimientos relacionados con el uso de bucles, condicionales, variables, entrada y salida de datos, así como el formateo de información en consola.

