namespace AssetTool
{
    [JsonAsset("AvaText3DComponent")]
    public class UAvaText3DComponent : UText3DComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}