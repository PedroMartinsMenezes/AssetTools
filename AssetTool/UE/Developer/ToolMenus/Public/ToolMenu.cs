namespace AssetTool
{
    [JsonAsset("ToolMenu")]
    public class UToolMenu : UToolMenuBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}