namespace AssetTool
{
    public class FMaterialParameterInfo : ITransferable
    {
        public FName Name;
        public EMaterialParameterAssociation Association;
        public Int32 Index;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            transfer.MoveEnum(ref Association);
            transfer.Move(ref Index);
            return this;
        }
    }

    public enum EMaterialParameterAssociation : Int32
    {
        LayerParameter,
        BlendParameter,
        GlobalParameter,
    };
}
