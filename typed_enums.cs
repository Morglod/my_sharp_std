using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Strong typed enum pattern

public class ELobbyState_StateName : StrEnum<ELobbyState_StateName>
{
    public static EValue making_party = Def("making_party");
    public static EValue playing_game = Def("playing_game");
}

// somewhere
ELobbyState_StateName.EValue = ELobbyState_StateName.making_party;

public class ELobbyState_Prefab : TEnum<ELobbyState_Prefab, Prefab>
{
    public static EValue player = Def(Prefab.get ...);
    public static EValue enemy = Def(Prefab.get ...);
}

// !! ATTENTION !!
to use Enum.Values you need to touch any defined value, otherwise it will be empty

*/
public class StrEnum<T>
{
    public struct EValue
    {
        public readonly string Value;

        public static implicit operator string(EValue self)
        {
            return self.Value;
        }

        public EValue(string v) {
            Value = v;
        }
    }

    public static List<EValue> Values = new List<EValue>();

    public static EValue Def(string v)
    {
        var x = new EValue(v);
        Values.Add(x);
        return x;
    }
}

public class TEnum<ParentT, T>
{
    public struct EValue
    {
        public readonly T Value;

        public EValue(T v)
        {
            Value = v;
        }

        public static implicit operator T(EValue self)
        {
            return self.Value;
        }
    }

    public static List<EValue> Values = new List<EValue>();

    public static EValue Def(T v)
    {
        var x = new EValue(v);
        Values.Add(x);
        return x;
    }
}