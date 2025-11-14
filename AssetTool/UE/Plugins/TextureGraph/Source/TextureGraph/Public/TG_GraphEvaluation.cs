namespace AssetTool
{
    [TransferableStruct("VarArgument")]
    public class FVarArgument : ITransferable
    {
        public UScriptStruct StaticStruct = new();
        public FTG_Argument Argument;
        public FTG_Var Var;

        [Location("Custom Serialize method for FVarArgument")]
        public ITransferable Move(Transfer transfer)
        {
            var dict = StaticStruct.SerializeItem(transfer);
            Argument ??= new FTG_Argument(dict);
            transfer.Move(ref Var, Argument);
            return this;
        }
    }
}
