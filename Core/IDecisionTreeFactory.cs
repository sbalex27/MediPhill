namespace Core
{
    public interface IDecisionTreeFactory
    {
        Node? Root { get; set; }

        void Configure();
        Node Create();
    }
}