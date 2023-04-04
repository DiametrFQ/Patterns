#Практическая работа №2

##О программе:
В этом коде мы создаем компанию, которая является Singleton'ом(Одиночкой). Затем мы создаем проект строительства и добавляем в него архитектурный дизайн с помощью декоратора Architect. Далее мы создаем две команды: StartConstructionCommand и CompleteConstructionCommand, которые будут использоваться для начала и завершения строительства соответственно. Мы также добавляем подрядчика в проект с помощью декоратора Contractor. Наконец, мы выполняем команду на начало строительства, строим дом и выполняем команду на завершение строительства.

##Одиночка
**Singleton(Одиночка) - это паттерн проектирования, который гарантирует, что для определенного класса будет создан только один объект, и этот объект будет доступен во всей программе. Целью этого паттерна является контроль над созданием объектов и уменьшение нагрузки на память.

##Декоратор
**Decorator(Декоратор) - это паттерн проектирования, который позволяет добавлять новое поведение или функциональность к объекту, не изменяя его исходного кода. Декораторы оборачивают исходный объект и добавляют новые методы или свойства, не нарушая инкапсуляцию. Этот паттерн часто используется для динамического добавления функциональности к объектам во время выполнения программы.

##Команда
**Command(Команда) - это паттерн проектирования, который позволяет инкапсулировать запрос в виде объекта, делая его доступным для дальнейшей обработки, передачи или отмены. Команды могут использоваться для реализации транзакций, отмены операций или истории выполненных действий. Команды также могут использоваться для реализации паттерна "Команда" в пользовательском интерфейсе, где каждое действие пользователя представляется в виде команды, которая может быть выполнена, отменена или повторена.
