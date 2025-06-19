namespace AssetTool
{
    [JsonAsset("Emitter")]
    public class AEmitter : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}