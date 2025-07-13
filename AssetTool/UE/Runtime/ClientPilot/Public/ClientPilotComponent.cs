namespace AssetTool
{
    [JsonAsset("ClientPilotComponent")]
    public class UClientPilotComponent : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}