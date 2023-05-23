namespace Core.Tree
{
    public class TreeInfantiles : ITree
    {
        public Node SubTree => new()
        {
            Label = "¿El niño tiene fiebre?",
            Confirm = new Node
            {
                Label = "¿El niño presenta erupción cutánea?",
                Confirm = new Node("Varicela"),
                Decline = new Node
                {
                    Label = "¿El niño tiene dolor de garganta?",
                    Confirm = new Node("Faringitis"),
                    Decline = new Node
                    {
                        Label = "¿El niño tiene congestión nasal y tos?",
                        Confirm = new Node("Resfriado común"),
                        Decline = new Node("Infección de oído")
                    }
                }
            },
            Decline = new Node
            {
                Label = "¿El niño tiene diarrea?",
                Confirm = new Node
                {
                    Label = "¿El niño ha estado expuesto a enfermedades infecciosas?",
                    Confirm = new Node("Gastroenteritis"),
                    Decline = new Node("Intolerancia alimentaria")
                },
                Decline = new Node
                {
                    Label = "¿El niño presenta problemas respiratorios y silbidos al respirar?",
                    Confirm = new Node("Asma"),
                    Decline = new Node
                    {
                        Label = "¿El niño tiene dolor abdominal?",
                        Confirm = new Node("Apendicitis"),
                        Decline = new Node("Estreñimiento")
                    }
                }
            }
        };
    }
}