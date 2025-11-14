namespace AssetTool
{
    [JsonAsset("Emitter")]
    public class AEmitter : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}