namespace AssetTool
{
    [JsonAsset("DMXComponent")]
    public class UDMXComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}