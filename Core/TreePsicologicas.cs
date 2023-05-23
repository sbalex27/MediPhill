namespace Core
{
    public class TreePsicologicas : ITree
    {
        public Node SubTree => new()
        {
            Label = "¿Tiene cambios de humor extremos?",
            Confirm = new Node
            {
                Label = "¿Ha experimentado episodios de euforia excesiva?",
                Confirm = new Node("Trastorno bipolar"),
                Decline = new Node
                {
                    Label = "¿Ha experimentado periodos prolongados de tristeza y falta de interés?",
                    Confirm = new Node("Trastorno depresivo mayor"),
                    Decline = new Node
                    {
                        Label = "¿Tiene dificultad para controlar los impulsos y la conducta?",
                        Confirm = new Node("Trastorno de control de los impulsos"),
                        Decline = new Node("Trastorno de ansiedad")
                    }
                }
            },
            Decline = new Node
            {
                Label = "¿Tiene pensamientos o creencias irracionales?",
                Confirm = new Node
                {
                    Label = "¿Escucha voces o tiene alucinaciones?",
                    Confirm = new Node("Esquizofrenia"),
                    Decline = new Node
                    {
                        Label = "¿Tiene obsesiones y compulsiones recurrentes?",
                        Confirm = new Node("Trastorno obsesivo-compulsivo"),
                        Decline = new Node
                        {
                            Label = "¿Ha experimentado episodios de miedo intenso y repentino?",
                            Confirm = new Node("Trastorno de pánico"),
                            Decline = new Node("Trastorno de estrés postraumático")
                        }
                    }
                },
                Decline = new Node
                {
                    Label = "¿Tiene dificultad para concentrarse y mantener la atención?",
                    Confirm = new Node("Trastorno por déficit de atención e hiperactividad (TDAH)"),
                    Decline = new Node("Trastorno de personalidad")
                }
            }
        };
    }
}