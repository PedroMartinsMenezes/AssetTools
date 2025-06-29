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
            transfer.MoveEnum(ref Association);
            transfer.Move(ref Index);
        }
    }

    public enum EMaterialParameterAssociation : Int32
    {
        LayerParameter,
        BlendParameter,
        GlobalParameter,
    };
}
