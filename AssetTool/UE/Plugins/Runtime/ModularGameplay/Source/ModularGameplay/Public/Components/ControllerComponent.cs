namespace AssetTool
{
    [JsonAsset("ControllerComponent")]
    public class UControllerComponent : UGameFrameworkComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}