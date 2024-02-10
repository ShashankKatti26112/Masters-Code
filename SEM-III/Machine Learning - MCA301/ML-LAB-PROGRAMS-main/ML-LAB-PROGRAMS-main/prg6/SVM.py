import matplotlib.pyplot as plt
from sklearn.model_selection import train_test_split
from sklearn.metrics import classification_report, confusion_matrix, accuracy_score

df=pd.read_csv("C:/Users/MCA/Downloads/placement.csv")
# print(df)
# print(df.info())
#print(df.isnull().sum())
#there is no null values in it soo the dataset s said to be cleaned

#print(df.shape)

#sns.countplot(x="status",data=df)
#plt.show()


#deleting the unwanted rows
df.drop(['sl_no','gender','ssc_b','hsc_b','hsc_s','degree_t','specialisation'],axis=1,inplace=True)
# print(df.info())
# print(df)

#converting the workex string to the numeric
from sklearn.preprocessing import LabelEncoder
enc=LabelEncoder()
df['workex']=enc.fit_transform(df['workex'])
#print(df)


#features--------X
x=df.drop('status',axis=1)

#target-------Y
y=df['status']
x_train, x_test, y_train, y_test=train_test_split(x,y,test_size=0.3,random_state=1)

#training the samples
from sklearn.naive_bayes import GaussianNB
model=GaussianNB()
model.fit(x_train,y_train)

#printing the catual output an the predicted output
y_pred=model.predict(x_test)
df1=pd.DataFrame({'Actual Status':y_test, 'Predicted Status':y_pred})
#print(df1)

print(classification_report(y_test, y_pred))
print(confusion_matrix(y_test, y_pred))


#printing the accuracy between the actual output nad the predicted output
print(accuracy_score(y_test,y_pred)*100)

import joblib
joblib.dump(model,"classifier.pkl")
my_model=joblib.load("C:/Users/MCA/PycharmProjects/pythonProject/classifier.pkl")
print(my_model.predict([[89.90,75.90,45.90,00,67.9,78.67]]))