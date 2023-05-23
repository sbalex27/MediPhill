namespace Core
{
    public class TreeVasculares : ITree
    {
        public Node SubTree => new()
        {
            Label = "¿Tiene presión arterial alta?",
            Confirm = new Node
            {
                Label = "¿Ha experimentado dolor en el pecho?",
                Confirm = new Node
                {
                    Label = "¿El dolor se irradia hacia el brazo izquierdo?",
                    Confirm = new Node("Infarto de miocardio"),
                    Decline = new Node("Angina de pecho")
                },
                Decline = new Node
                {
                    Label = "¿Tiene dificultad para respirar?",
                    Confirm = new Node
                    {
                        Label = "¿Ha notado hinchazón en las piernas o los tobillos?",
                        Confirm = new Node("Insuficiencia cardíaca"),
                        Decline = new Node("Hipertensión arterial")
                    },
                    Decline = new Node("Hipertensión arterial")
                }
            },
            Decline = new Node
            {
                Label = "¿Ha experimentado palpitaciones?",
                Confirm = new Node
                {
                    Label = "¿Tiene mareos o desmayos asociados?",
                    Confirm = new Node("Arritmia"),
                    Decline = new Node("Hipotensión")
                },
                Decline = new Node
                {
                    Label = "¿Ha experimentado dolor en las piernas al caminar?",
                    Confirm = new Node("Enfermedad arterial periférica"),
                    Decline = new Node("Sin enfermedad cardiovascular")
                }
            }
        };
    }
}