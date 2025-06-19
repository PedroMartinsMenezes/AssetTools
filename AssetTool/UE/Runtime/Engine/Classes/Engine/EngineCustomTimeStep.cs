namespace AssetTool
{
    [JsonAsset("EngineCustomTimeStep")]
    public class UEngineCustomTimeStep : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}