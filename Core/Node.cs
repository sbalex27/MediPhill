namespace Core
{
    /// <summary>
    /// Clase que representa un nodo del árbol de decisiones, puede ser
    /// instanciado con un constructor vacío o bien únicamente con su
    /// Label correspondiente, además puede ser instanciado por medio
    /// de un constructor implícito con referencia a más nodos.
    /// </summary>
    public class Node
    {
        public Node() { }

        /// <summary>
        /// Inicializa el nodo
        /// </summary>
        /// <param name="label">Etiqueta descriptiva del nodo</param>
        public Node(string label)
        {
            Label = label;
        }

        /// <summary>
        /// Etiqueta descriptiva del nodo
        /// </summary>
        public string Label { get; set; } = null!;
        /// <summary>
        /// Referencia a Nodo en caso de confirmación de condicional
        /// </summary>
        public Node? Confirm { get; set; }
        /// <summary>
        /// Referencia a Nodo en caso de rechazo de condicional
        /// </summary>
        public Node? Decline { get; set; }
    }
}