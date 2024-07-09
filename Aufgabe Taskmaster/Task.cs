using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Taskmaster
{
    public class Task
    {
        // Wir definieren die 4 Eigenschaften/Properties die unsere künftigen Objekte haben können
        internal string Title { get; set; }
        internal string Description { get; set; }
        internal DateTime DueDate { get; set; }
        internal bool IsCompleted { get; set; }

        // Die folgenden Zeilen werden "Konstruktor" genannt:
        public Task(string title, string description, DateTime dueDate, bool isCompleted)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = isCompleted;
        }

        // Wenn wir die Methode GetTaskInfo() an unserem Objekt aufrufen erscheinen die Eigenschaften/Properties unseres Objekts in der Konsole
        public string GetTaskInfo()
        {
            return $"\nTITEL: {Title}, \nBESCHREIBUNG; {Description}, \nFÄLLIG BIS: {DueDate}, \nERLEDIGT: {IsCompleted}\n";
        }

        // Markierung der Aufgabe als erledigt. Methode CompleteTask() ändert das bool auf true wenn sie ausgeführt wird (egal welches Objekt)
        public void CompleteTask()
        {
            IsCompleted = true ;
        }

        // Verlängerung des Fälligkeitsdatums. Das grüne DateTime kommt aus C# und der Umgang damit muss auswendig gelernt werden.
        public void ExtendDueDate(DateTime newDueDate)
        {
            DueDate = newDueDate;
        }
    }
}
