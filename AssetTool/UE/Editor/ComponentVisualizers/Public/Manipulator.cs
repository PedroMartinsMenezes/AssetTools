namespace AssetTool
{
    [JsonAsset("Manipulator")]
    public class AManipulator : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}