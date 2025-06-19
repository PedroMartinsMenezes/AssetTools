namespace AssetTool
{
    [JsonAsset("DMXComponent")]
    public class UDMXComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}