namespace AssetTool
{
    [TransferibleStruct("VarArgument")]
    public class FVarArgument : ITransferible
    {
        public UScriptStruct StaticStruct = new();
        public FTG_Argument Argument;
        public FTG_Var Var;

        [Location("Custom Serialize method for FVarArgument")]
        public ITransferible Move(Transfer transfer)
        {
            var dict = StaticStruct.SerializeItem(transfer);
            Argument ??= new FTG_Argument(dict);
            transfer.Move(ref Var, Argument);
            return this;
        }
    }
}
