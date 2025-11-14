namespace AssetTool
{
    [JsonAsset("Manipulator")]
    public class AManipulator : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}