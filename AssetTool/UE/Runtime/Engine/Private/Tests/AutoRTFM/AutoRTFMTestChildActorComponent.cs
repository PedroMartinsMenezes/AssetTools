namespace AssetTool
{
    [JsonAsset("AutoRTFMTestChildActorComponent")]
    public class UAutoRTFMTestChildActorComponent : UChildActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}