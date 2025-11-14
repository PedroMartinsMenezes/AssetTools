namespace AssetTool
{
    [JsonAsset("AvaCineCameraActor")]
    public class AAvaCineCameraActor : ACineCameraActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}