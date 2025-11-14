namespace AssetTool
{
    [JsonAsset("TestTypedElementInterfaceA_ImplTyped")]
    public class UTestTypedElementInterfaceA_ImplTyped : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestTypedElementInterfaceA_ImplUntyped")]
    public class UTestTypedElementInterfaceA_ImplUntyped : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestTypedElementInterfaceBAndC_Typed")]
    public class UTestTypedElementInterfaceBAndC_Typed : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}