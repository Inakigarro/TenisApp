# Secciones de la aplicacion

## Seccion de Administracion de usuarios

Deberia permitirnos hacer operaciones basicas con usuarios:

- Crear usuarios
- Obtener usuarios
- Modificar usuarios
- Deshabilitar ususarios

### Tipos de usuarios

- Usuario administrador: Permisos sobre toda la aplicacion y todas las posibles operaciones.
- Profesores: Tienen prioridad al momento de reservar turnos en una cancha y deberian ser
    capaces de bloquear completamente todos los horarios de una cancha.
- Socios: Usuario comun de la app.
- No socios: Solo deberia tener acceso a lectura. No deberia poder reservar canchas,
    ni turnos, ni nada.

## Seccion de administracion de canchas

Deberia permitirnos hacer operaciones basicas con canchas:

- Crear canchas
- Obtener canchas
- Modificar canchas
- Deshabilitar canchas

cada cancha deberia tener un listado de turnos. Listado de horarios
de lunes a viernes, entre las 8hs y las 22hs

## Seccion de administracion de turnos

Deberia permitir hacer operaciones basicas con turnos.

- Hora Inicio.
- Hora de Fin.
- Costo por hora.
- Usuario que reservo el turno.
- Cancha del turno.

Se debe poder reservar un turno fijo. Ejemplo `Todos los lunes, de 17 a 19hs`

