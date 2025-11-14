namespace AssetTool
{
    [JsonAsset("EQSTestingPawn")]
    public class AEQSTestingPawn : ACharacter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}