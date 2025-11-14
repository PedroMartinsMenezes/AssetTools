namespace AssetTool
{
    [JsonAsset("ToolMenuSectionDynamic")]
    public class UToolMenuSectionDynamic : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}