namespace Core
{
    /// <summary>
    /// Representa un fragmento del árbol que contiene un grupo de objetos
    /// relacionados entre si que pueden ser fusionados con el resto del 
    /// árbol convirtiendo su arquitectura en modular
    /// </summary>
    public interface ITree
    {
        /// <summary>
        /// Sub árbol modular con registros en común
        /// </summary>
        public Node SubTree { get; }
    }
}