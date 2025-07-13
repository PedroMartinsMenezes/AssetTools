namespace AssetTool
{
    [JsonAsset("GameFrameworkComponent")]
    public class UGameFrameworkComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}