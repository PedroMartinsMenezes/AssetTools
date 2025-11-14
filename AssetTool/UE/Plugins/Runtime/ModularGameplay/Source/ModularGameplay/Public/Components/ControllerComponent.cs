namespace AssetTool
{
    [JsonAsset("ControllerComponent")]
    public class UControllerComponent : UGameFrameworkComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}