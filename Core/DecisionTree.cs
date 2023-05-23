namespace Core
{
    public class Node
    {
        public Node() { }

        public Node(string label)
        {
            Label = label;
        }

        public string Label { get; set; } = null!;
        public Node? Confirm { get; set; }
        public Node? Decline { get; set; }
    }

    public class DecisionTree
    {
        public Node? Root { get; set; }

        public Node Create()
        {
            if (Root is null)
            {
                throw new NullReferenceException("Debe inicializar el árbol de decisiones para proceder");
            }
            else
            {
                return Root;
            }
        }

        public void Configure()
        {
            ITree vasculares = new TreeVasculares();
            ITree psicologicas = new TreePsicologicas();
            ITree infantiles = new TreeInfantiles();
            ITree generales = new TreeGenerales();

            Root = new Node
            {
                Label = "Es menor de edad?",
                Confirm = infantiles.SubTree,
                Decline = new Node
                {
                    Label = "Es de la tercera edad?",
                    Confirm = vasculares.SubTree,
                    Decline = new Node
                    {
                        Label = "Tiene antecedentes cardiovasculares?",
                        Confirm = vasculares.SubTree,
                        Decline = new Node
                        {
                            Label = "Tiene antecedentes psiquiatrico/psicológicos?",
                            Confirm = psicologicas.SubTree,
                            Decline = generales.SubTree,
                        }
                    }
                }
            };
        }

    }
}