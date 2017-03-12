# Theater Kata
Usted trabaja para un teatro, y está trabajando en un sistema de sugerencias para asignaciones de asientos. Durante el proceso de compra de entradas, el cliente se ofrece los mejores asientos disponibles en un rango de precio dado. Se les mostrará un diagrama del teatro con todos los asientos disponibles mostrados, y los asientos sugeridos destacados. El cliente podrá cambiar a diferentes asientos como desee. No es necesario escribir el código para mostrar el diseño del teatro con los asientos sugeridos resaltados. Sólo tienes que escribir el código que decide qué asientos sugerir. Usted tiene acceso a un archivo json con todos los asientos en el teatro y que también las listas que ya están reservadas. Ofrecer asientos siguiendo estas reglas:

- No ofrecen ningún asiento que ya ha sido reservado por otro cliente
- Ofrecen asientos cerca del centro de una fila
- Ofrecen asientos cerca del frente
- Si es posible, ofrecer asientos adyacentes a miembros de la misma parte
- Las partes de más de 6 se pueden dividir en grupos que se sientan juntos, con al menos 2 en cada grupo.
- Evitar dejar asientos individuales sin reservar en una fila.
- Como último recurso, ofrecen asientos que no están adyacentes.

Traducción de https://github.com/emilybache/Theater-Kata del github de Emily Bache https://github.com/emilybache