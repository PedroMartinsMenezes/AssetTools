namespace AssetTool
{
    public class FRigVMByteCode : ITransferible
    {
        public List<byte> ByteCode;
        public Int32 InstructionCount;
        public List<ERigVMOpCode> OpCodes = [];
        public Dictionary<int, (FRigVMExecuteOp, List<FRigVMOperand>)> ExecuteOps = [];
        public Dictionary<int, FRigVMCopyOp> CopyOps = [];
        public Dictionary<int, FRigVMUnaryOp> UnaryOps = [];
        public Dictionary<int, FRigVMComparisonOp> ComparisonOps = [];
        public Dictionary<int, FRigVMJumpOp> JumpOps = [];
        public Dictionary<int, FRigVMJumpIfOp> JumpIfOps = [];
        public Dictionary<int, FRigVMBinaryOp> BinaryOps = [];
        public Dictionary<int, FRigVMTernaryOp> TernaryOps = [];
        public Dictionary<int, FRigVMQuaternaryOp> QuaternaryOps = [];
        public Dictionary<int, FRigVMSenaryOp> SenaryOps = [];
        public Dictionary<int, FRigVMInvokeEntryOp> InvokeEntryOps = [];
        public Dictionary<int, FRigVMJumpToBranchOp> JumpToBranchOps = [];
        public List<FString> View;
        public List<FRigVMBranchInfo> BranchInfos;

        [Location("void FRigVMByteCode::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            if (!Supports.StoreMarkerNamesOnSkeleton)
            {
                return this;
            }
            #region Load
            if (!Supports.RigVMByteCodeDeterminism)
            {
                transfer.Move(ref ByteCode);

                return this;
            }
            transfer.Move(ref InstructionCount);
            OpCodes.Resize(transfer, InstructionCount);

            for (int InstructionIndex = 0; InstructionIndex < InstructionCount; InstructionIndex++)
            {
                ERigVMOpCode OpCode = OpCodes[InstructionIndex] = (ERigVMOpCode)transfer.Move((byte)OpCodes[InstructionIndex]);
                if (OpCode >= ERigVMOpCode.Execute_0_Operands && OpCode <= ERigVMOpCode.Execute_64_Operands)
                    OpCode = ERigVMOpCode.Execute;
                switch (OpCode)
                {
                    case ERigVMOpCode.Execute:
                        {
                            ExecuteOps[InstructionIndex] = ExecuteOps.ContainsKey(InstructionIndex) ? ExecuteOps[InstructionIndex] : (new(), []);
                            ExecuteOps[InstructionIndex].Item1.Move(transfer);
                            int OperandCount = ExecuteOps[InstructionIndex].Item1.GetOperandCount();
                            List<FRigVMOperand> Operands = ExecuteOps[InstructionIndex].Item2;
                            transfer.Move(ref Operands, OperandCount);
                            break;
                        }
                    case ERigVMOpCode.Copy:
                        {
                            CopyOps[InstructionIndex] = CopyOps.ContainsKey(InstructionIndex) ? CopyOps[InstructionIndex] : new();
                            CopyOps[InstructionIndex].Move(transfer);
                            break;
                        }
                    case ERigVMOpCode.Zero:
                    case ERigVMOpCode.BoolFalse:
                    case ERigVMOpCode.BoolTrue:
                    case ERigVMOpCode.Increment:
                    case ERigVMOpCode.Decrement:
                    case ERigVMOpCode.ArrayReset:
                    case ERigVMOpCode.ArrayReverse:
                        {
                            UnaryOps[InstructionIndex] = UnaryOps.ContainsKey(InstructionIndex) ? UnaryOps[InstructionIndex] : new();
                            UnaryOps[InstructionIndex].Move(transfer);
                            break;
                        }
                    case ERigVMOpCode.Equals:
                    case ERigVMOpCode.NotEquals:
                        {
                            ComparisonOps[InstructionIndex] = ComparisonOps.ContainsKey(InstructionIndex) ? ComparisonOps[InstructionIndex] : new();
                            ComparisonOps[InstructionIndex].Move(transfer);
                            break;
                        }
                    case ERigVMOpCode.JumpAbsolute:
                    case ERigVMOpCode.JumpForward:
                    case ERigVMOpCode.JumpBackward:
                        {
                            JumpOps[InstructionIndex] = JumpOps.ContainsKey(InstructionIndex) ? JumpOps[InstructionIndex] : new();
                            JumpOps[InstructionIndex].Move(transfer);
                            break;
                        }
                    case ERigVMOpCode.JumpAbsoluteIf:
                    case ERigVMOpCode.JumpForwardIf:
                    case ERigVMOpCode.JumpBackwardIf:
                        {
                            JumpIfOps[InstructionIndex] = JumpIfOps.ContainsKey(InstructionIndex) ? JumpIfOps[InstructionIndex] : new();
                            JumpIfOps[InstructionIndex].Move(transfer);
                            break;
                        }
                    case ERigVMOpCode.Exit:
                        {
                            break;
                        }
                    case ERigVMOpCode.BeginBlock:
                    case ERigVMOpCode.ArrayGetNum:
                    case ERigVMOpCode.ArraySetNum:
                    case ERigVMOpCode.ArrayAppend:
                    case ERigVMOpCode.ArrayClone:
                    case ERigVMOpCode.ArrayRemove:
                    case ERigVMOpCode.ArrayUnion:
                        {
                            BinaryOps[InstructionIndex] = BinaryOps.ContainsKey(InstructionIndex) ? BinaryOps[InstructionIndex] : new();
                            BinaryOps[InstructionIndex].Move(transfer);
                            break;
                        }
                    case ERigVMOpCode.ArrayAdd:
                    case ERigVMOpCode.ArrayGetAtIndex:
                    case ERigVMOpCode.ArraySetAtIndex:
                    case ERigVMOpCode.ArrayInsert:
                    case ERigVMOpCode.ArrayDifference:
                    case ERigVMOpCode.ArrayIntersection:
                        {
                            TernaryOps[InstructionIndex] = TernaryOps.ContainsKey(InstructionIndex) ? TernaryOps[InstructionIndex] : new();
                            TernaryOps[InstructionIndex].Move(transfer);
                            break;
                        }
                    case ERigVMOpCode.ArrayFind:
                        {
                            QuaternaryOps[InstructionIndex] = QuaternaryOps.ContainsKey(InstructionIndex) ? QuaternaryOps[InstructionIndex] : new();
                            QuaternaryOps[InstructionIndex].Move(transfer);
                            break;
                        }
                    case ERigVMOpCode.ArrayIterator:
                        {
                            SenaryOps[InstructionIndex] = SenaryOps.ContainsKey(InstructionIndex) ? SenaryOps[InstructionIndex] : new();
                            SenaryOps[InstructionIndex].Move(transfer);
                            break;
                        }
                    case ERigVMOpCode.EndBlock:
                        {
                            break;
                        }
                    case ERigVMOpCode.InvokeEntry:
                        {
                            InvokeEntryOps[InstructionIndex] = InvokeEntryOps.ContainsKey(InstructionIndex) ? InvokeEntryOps[InstructionIndex] : new();
                            InvokeEntryOps[InstructionIndex].Move(transfer);
                            break;
                        }
                    case ERigVMOpCode.JumpToBranch:
                        {
                            JumpToBranchOps[InstructionIndex] = JumpToBranchOps.ContainsKey(InstructionIndex) ? JumpToBranchOps[InstructionIndex] : new();
                            JumpToBranchOps[InstructionIndex].Move(transfer);
                            break;
                        }
                }
            }

            if (Supports.SerializeRigVMEntries)
            {
                transfer.Move(ref View);
            }
            if (Supports.RigVMLazyEvaluation)
            {
                transfer.Move(ref BranchInfos);
            }

            #endregion
            return this;
        }
    }

    public class FRigVMBaseOp
    {
        public ERigVMOpCode OpCode;
    }

    public class FRigVMExecuteOp : FRigVMBaseOp, ITransferible
    {
        public UInt16 FunctionIndex;
        public UInt16 ArgumentCount;
        public UInt16 FirstPredicateIndex;
        public UInt16 PredicateCount;

        private UInt16 OperandCount;

        [Location("void FRigVMExecuteOp::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            OpCode = (ERigVMOpCode)transfer.Move((byte)OpCode);
            transfer.Move(ref FunctionIndex);
            if (OpCode >= ERigVMOpCode.Execute_0_Operands && OpCode <= ERigVMOpCode.Execute_64_Operands)
            {
                OperandCount = (UInt16)(OpCode - ERigVMOpCode.Execute_0_Operands);
            }
            else
            {
                transfer.Move(ref ArgumentCount);
                OperandCount = ArgumentCount;
            }
            if (Supports.PredicatesAddedToExecuteOps)
            {
                transfer.Move(ref FirstPredicateIndex);
                transfer.Move(ref PredicateCount);
            }
            return this;
        }

        public UInt16 GetOperandCount()
        {
            return OperandCount;
        }
    }

    public class FRigVMCopyOp : FRigVMBaseOp, ITransferible
    {
        public FRigVMOperand Source;
        public FRigVMOperand Target;
        public UInt16 NumBytes;
        public ERigVMRegisterType RegisterType;

        [Location("void FRigVMCopyOp::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            OpCode = (ERigVMOpCode)transfer.Move((byte)OpCode);
            transfer.Move(ref Source);
            transfer.Move(ref Target);

            if (Supports.RigVMCopyOpStoreNumBytes)
            {
                transfer.Move(ref NumBytes);
                RegisterType = (ERigVMRegisterType)transfer.Move((byte)RegisterType);
            }

            return this;
        }
    }

    public class FRigVMUnaryOp : FRigVMBaseOp, ITransferible
    {
        public FRigVMOperand Arg;

        [Location("void FRigVMUnaryOp::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            OpCode = (ERigVMOpCode)transfer.Move((byte)OpCode);
            transfer.Move(ref Arg);
            return this;
        }
    }

    public class FRigVMComparisonOp : FRigVMBaseOp, ITransferible
    {
        public FRigVMOperand A;
        public FRigVMOperand B;
        public FRigVMOperand Result;

        [Location("void FRigVMComparisonOp::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            OpCode = (ERigVMOpCode)transfer.Move((byte)OpCode);
            transfer.Move(ref A);
            transfer.Move(ref B);
            transfer.Move(ref Result);
            return this;
        }
    }

    public class FRigVMJumpOp : FRigVMBaseOp, ITransferible
    {
        public Int32 InstructionIndex;

        [Location("void FRigVMJumpOp::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            OpCode = (ERigVMOpCode)transfer.Move((byte)OpCode);
            transfer.Move(ref InstructionIndex);
            return this;
        }
    }

    public class FRigVMJumpIfOp : FRigVMBaseOp, ITransferible
    {
        public FRigVMOperand Arg;
        public Int32 InstructionIndex;
        public FBool Condition;

        [Location("void FRigVMJumpIfOp::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            OpCode = (ERigVMOpCode)transfer.Move((byte)OpCode);
            transfer.Move(ref Arg);
            transfer.Move(ref InstructionIndex);
            transfer.Move(ref Condition);
            return this;
        }
    }

    public class FRigVMBinaryOp : FRigVMBaseOp, ITransferible
    {
        public FRigVMOperand ArgA;
        public FRigVMOperand ArgB;

        [Location("void FRigVMBinaryOp::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            OpCode = (ERigVMOpCode)transfer.Move((byte)OpCode);
            transfer.Move(ref ArgA);
            transfer.Move(ref ArgB);
            return this;
        }
    }

    public class FRigVMTernaryOp : FRigVMBaseOp, ITransferible
    {
        public FRigVMOperand ArgA;
        public FRigVMOperand ArgB;
        public FRigVMOperand ArgC;

        [Location("void FRigVMTernaryOp::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            OpCode = (ERigVMOpCode)transfer.Move((byte)OpCode);
            transfer.Move(ref ArgA);
            transfer.Move(ref ArgB);
            transfer.Move(ref ArgC);
            return this;
        }
    }

    public class FRigVMQuaternaryOp : FRigVMBaseOp, ITransferible
    {
        public FRigVMOperand ArgA;
        public FRigVMOperand ArgB;
        public FRigVMOperand ArgC;
        public FRigVMOperand ArgD;

        [Location("void FRigVMQuaternaryOp::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            OpCode = (ERigVMOpCode)transfer.Move((byte)OpCode);
            transfer.Move(ref ArgA);
            transfer.Move(ref ArgB);
            transfer.Move(ref ArgC);
            transfer.Move(ref ArgD);
            return this;
        }
    }

    public class FRigVMSenaryOp : FRigVMBaseOp, ITransferible
    {
        public FRigVMOperand ArgA;
        public FRigVMOperand ArgB;
        public FRigVMOperand ArgC;
        public FRigVMOperand ArgD;
        public FRigVMOperand ArgE;
        public FRigVMOperand ArgF;

        [Location("void FRigVMSenaryOp::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            OpCode = (ERigVMOpCode)transfer.Move((byte)OpCode);
            transfer.Move(ref ArgA);
            transfer.Move(ref ArgB);
            transfer.Move(ref ArgC);
            transfer.Move(ref ArgD);
            transfer.Move(ref ArgE);
            transfer.Move(ref ArgF);
            return this;
        }
    }

    public class FRigVMInvokeEntryOp : FRigVMBaseOp, ITransferible
    {
        public FString EntryNameString;

        [Location("void FRigVMInvokeEntryOp::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref EntryNameString);
            return this;
        }
    }

    public class FRigVMJumpToBranchOp : FRigVMBaseOp, ITransferible
    {
        public FRigVMOperand Arg;
        public Int32 FirstBranchInfoIndex;

        [Location("void FRigVMJumpToBranchOp::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            OpCode = (ERigVMOpCode)transfer.Move((byte)OpCode);
            transfer.Move(ref Arg);
            transfer.Move(ref FirstBranchInfoIndex);
            return this;
        }
    }

    public enum ERigVMOpCode : byte
    {
        Execute_0_Operands,
        Execute_1_Operands,
        Execute_2_Operands,
        Execute_3_Operands,
        Execute_4_Operands,
        Execute_5_Operands,
        Execute_6_Operands,
        Execute_7_Operands,
        Execute_8_Operands,
        Execute_9_Operands,
        Execute_10_Operands,
        Execute_11_Operands,
        Execute_12_Operands,
        Execute_13_Operands,
        Execute_14_Operands,
        Execute_15_Operands,
        Execute_16_Operands,
        Execute_17_Operands,
        Execute_18_Operands,
        Execute_19_Operands,
        Execute_20_Operands,
        Execute_21_Operands,
        Execute_22_Operands,
        Execute_23_Operands,
        Execute_24_Operands,
        Execute_25_Operands,
        Execute_26_Operands,
        Execute_27_Operands,
        Execute_28_Operands,
        Execute_29_Operands,
        Execute_30_Operands,
        Execute_31_Operands,
        Execute_32_Operands,
        Execute_33_Operands,
        Execute_34_Operands,
        Execute_35_Operands,
        Execute_36_Operands,
        Execute_37_Operands,
        Execute_38_Operands,
        Execute_39_Operands,
        Execute_40_Operands,
        Execute_41_Operands,
        Execute_42_Operands,
        Execute_43_Operands,
        Execute_44_Operands,
        Execute_45_Operands,
        Execute_46_Operands,
        Execute_47_Operands,
        Execute_48_Operands,
        Execute_49_Operands,
        Execute_50_Operands,
        Execute_51_Operands,
        Execute_52_Operands,
        Execute_53_Operands,
        Execute_54_Operands,
        Execute_55_Operands,
        Execute_56_Operands,
        Execute_57_Operands,
        Execute_58_Operands,
        Execute_59_Operands,
        Execute_60_Operands,
        Execute_61_Operands,
        Execute_62_Operands,
        Execute_63_Operands,
        Execute_64_Operands,
        Zero,
        BoolFalse,
        BoolTrue,
        Copy,
        Increment,
        Decrement,
        Equals,
        NotEquals,
        JumpAbsolute,
        JumpForward,
        JumpBackward,
        JumpAbsoluteIf,
        JumpForwardIf,
        JumpBackwardIf,
        ChangeType,
        Exit,
        BeginBlock,
        EndBlock,
        ArrayReset,
        ArrayGetNum,
        ArraySetNum,
        ArrayGetAtIndex,
        ArraySetAtIndex,
        ArrayAdd,
        ArrayInsert,
        ArrayRemove,
        ArrayFind,
        ArrayAppend,
        ArrayClone,
        ArrayIterator,
        ArrayUnion,
        ArrayDifference,
        ArrayIntersection,
        ArrayReverse,
        InvokeEntry,
        JumpToBranch,
        Execute,
        Invalid,
        FirstArrayOpCode = ArrayReset,
        LastArrayOpCode = ArrayReverse,
    }
}
