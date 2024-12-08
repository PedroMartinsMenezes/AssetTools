namespace AssetTool
{
    [JsonAsset("EngineCustomTimeStep")]
    public class UEngineCustomTimeStep : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}