namespace AssetTool
{
    public class FMaterialParameterInfo
    {
        public FName Name;
        public EMaterialParameterAssociation Association;
        public Int32 Index;

        public void Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            Association = (EMaterialParameterAssociation)transfer.Move((byte)Association);
            transfer.Move(ref Index);
        }
    }

    public enum EMaterialParameterAssociation
    {
        LayerParameter,
        BlendParameter,
        GlobalParameter,
    };
}
