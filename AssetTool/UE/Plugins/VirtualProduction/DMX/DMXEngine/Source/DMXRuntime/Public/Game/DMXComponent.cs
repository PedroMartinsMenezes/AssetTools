namespace AssetTool
{
    [JsonAsset("DMXComponent")]
    public class UDMXComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}