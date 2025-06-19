namespace AssetTool
{
    [JsonAsset("EQSTestingPawn")]
    public class AEQSTestingPawn : ACharacter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}