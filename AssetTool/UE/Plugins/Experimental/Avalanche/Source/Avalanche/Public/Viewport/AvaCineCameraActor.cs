namespace AssetTool
{
    [JsonAsset("AvaCineCameraActor")]
    public class AAvaCineCameraActor : ACineCameraActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}