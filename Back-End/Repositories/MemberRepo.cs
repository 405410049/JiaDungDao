using System;
using System.Linq;
using System.Threading.Tasks;
using Back_End.Interface;
using Back_End.Models;
using JiaDungDao.Connection;
using Microsoft.EntityFrameworkCore;

namespace Back_End.Repositories {
    public class MemberRepo : IMemberRepo {
        private readonly ApplicationDbContext db;
        public MemberRepo (ApplicationDbContext dbContext) {
            this.db = dbContext;
        }

        public async Task<Member> GetMemberByLogin (string m_account, string hash_m_password) {
            return await db.Member.Where (m => m.m_account == m_account && m.m_password == hash_m_password).FirstOrDefaultAsync ();
        }

        public Member GetMemberByAcc (string m_account) {
            return db.Member.Where (m => m.m_account == m_account).FirstOrDefault ();
        }

        public string Register (Member member) {
            string result = string.Empty;
            try {
                db.Member.Add (member);
                db.SaveChanges ();
                result = "successed";
            } catch (Exception e) {
                result = e.Message.ToString ();
            }
            return result;
        }

        public string EditMemberInformation (Member originMember, UpdateMemberInfo memberAfterEdit) {
            string result = string.Empty;
            try {
                originMember.m_name = memberAfterEdit.m_name;
                originMember.m_address = memberAfterEdit.m_address;
                originMember.m_birthday = memberAfterEdit.m_birthday;
                originMember.m_email = memberAfterEdit.m_email;
                db.SaveChanges();
                result = "Update completed!";
            } catch (Exception e) {
                result = e.Message.ToString ();
            }
            return result;
        }
    }
}