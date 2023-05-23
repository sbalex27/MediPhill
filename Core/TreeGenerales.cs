namespace Core
{
    public class TreeGenerales : ITree
    {
        public Node SubTree => new()
        {
            Label = "¿Siente dolor en la parte superior del cuerpo?",
            Confirm = new Node
            {
                Label = "¿Tiene fiebre?",
                Confirm = new Node
                {
                    Label = "¿Tiene tos seca?",
                    Confirm = new Node("COVID-19"),
                    Decline = new Node("Resfriado común")
                },
                Decline = new Node
                {
                    Label = "¿Presenta congestión nasal?",
                    Confirm = new Node("Resfriado común"),
                    Decline = new Node
                    {
                        Label = "¿Tiene dolor de garganta?",
                        Confirm = new Node("Amigdalitis"),
                        Decline = new Node("Faringitis")
                    }
                }
            },
            Decline = new Node
            {
                Label = "¿Experimenta dolor en el pecho?",
                Confirm = new Node
                {
                    Label = "¿Tiene dificultad para respirar?",
                    Confirm = new Node("Neumonía"),
                    Decline = new Node("Bronquitis")
                },
                Decline = new Node
                {
                    Label = "¿Experimenta reacciones alérgicas?",
                    Confirm = new Node
                    {
                        Label = "¿Presenta problemas oculares?",
                        Confirm = new Node("Conjuntivitis alérgica"),
                        Decline = new Node("Rinitis alérgica")
                    },
                    Decline = new Node
                    {
                        Label = "¿Tiene problemas estomacales?",
                        Confirm = new Node("Gastritis"),
                        Decline = new Node
                        {
                            Label = "¿Tiene erupciones en la piel?",
                            Confirm = new Node("Dermatitis atópica"),
                            Decline = new Node("Colitis")
                        }
                    }
                }
            }
        };
    }
}