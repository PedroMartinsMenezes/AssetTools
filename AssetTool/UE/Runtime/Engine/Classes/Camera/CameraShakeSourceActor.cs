namespace AssetTool
{
    [JsonAsset("CameraShakeSourceActor")]
    public class ACameraShakeSourceActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}