namespace Security
{
    public interface ISecurityProvider
    {
        void Scan();
        void Modify();
    }
}
