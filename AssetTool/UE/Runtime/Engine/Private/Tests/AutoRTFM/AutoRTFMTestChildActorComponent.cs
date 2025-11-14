namespace AssetTool
{
    [JsonAsset("AutoRTFMTestChildActorComponent")]
    public class UAutoRTFMTestChildActorComponent : UChildActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}