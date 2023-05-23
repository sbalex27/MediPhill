namespace Core
{

    /// <summary>
    /// Fábrica de árboles de decisiones delegada de instanciar nuevos nodos raíz
    /// cuyo funcionamiento será determinar la enfermedad del paciente basado
    /// en una serie de factores
    /// 
    /// </summary>
    public class DecisionTreeFactory : IDisposable, IDecisionTreeFactory
    {
        public Node? Root { get; set; }

        /// <summary>
        /// Crea una nueva instancia de un nodo raíz que contiene el resto
        /// del árbol
        /// </summary>
        /// <returns>Nodo raíz con el árbol cargado en memoria</returns>
        /// <exception cref="NullReferenceException">Excepción lanzada cuando se intenta crear un 
        /// nuevo nodo raíz sin haber sido configurado</exception>
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

        public void Dispose()
        {
            Root = null;
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Configura el árbol de decisiones basado en una serie de subárboles
        /// delegados de contener cierto grupo de enfermedades relacionadas
        /// </summary>
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