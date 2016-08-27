using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC
{
	public class Cargo
	{
		public static int ID_Cargo { get; private set; }

		public static String Nome { get; private set; }

		public static bool ATIV_CRIAR { get; private set; }

		public static bool ATIV_EDIT { get; private set; }

		public static bool ATIV_CONS { get; private set; }

		public static bool NOTA_ATRIB { get; private set; }

		public static bool NOTA_CONS { get; private set; }

		public static bool ALUNO_CADS { get; private set; }

		public static bool ALUNO_CONS { get; private set; }

		public static bool ALUNO_EDIT { get; private set; }

		public static bool FUNC_CADS { get; private set; }

		public static bool FUNC_CONS { get; private set; }

		public static bool FUNC_EDIT { get; private set; }

		public static bool PROF_CADS { get; private set; }

		public static bool PROF_CONS { get; private set; }

		public static bool PROF_EDIT { get; private set; }
	}
}
