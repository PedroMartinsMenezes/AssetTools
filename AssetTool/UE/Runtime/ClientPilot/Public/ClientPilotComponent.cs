namespace AssetTool
{
    [JsonAsset("ClientPilotComponent")]
    public class UClientPilotComponent : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}